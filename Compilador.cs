using Compilador.App.models;
using Compilador.App.transversal;
using Compilador.App.analisisLexico;
using Compilador.App.TablaSimbolos;
namespace Compilador;

public partial class Compilador : Form
{

    OpenFileDialog OpenFile = new OpenFileDialog();
    string ArchiveReference;
    //private Cache cache = new Cache();
    public Compilador()
    {
        InitializeComponent();
        //cache = Cache.getCache();
    }

    private void btnProcesar_Click(object sender, EventArgs e)
    {
        if (rbtnConsola.Checked)
        {
            ReadConsole();
            SaveLineInFile();
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (txtConsoleEdit.Text != "")
        {
            btnProcesar.Enabled = true;
        }
        else
        {
            btnProcesar.Enabled=false;
        }
    }

    private void Compilador_Load(object sender, EventArgs e)
    {
        btnProcesar.Enabled = false;
        btnCompilar.Enabled= false;
        rbtnConsola.Checked = true;
        txtArchivo.Hide();
        btnCargar.Hide();
        dataGridView1.Hide();
        btnCompilar.Show();
    }

    private void rbtnArchivo_CheckedChanged(object sender, EventArgs e)
    {
        if (rbtnArchivo.Checked)
        {
            btnCargar.Location = new Point(733, 104);
            txtArchivo.Show();
            btnCargar.Show();
            btnProcesar.Hide();
            txtConsoleEdit.Hide();
            txtConsoleEdit.ResetText();
        }
    }

    private void rbtnConsola_CheckedChanged(object sender, EventArgs e)
    {
        if (rbtnConsola.Checked)
        {
            btnCargar.Hide();
            txtArchivo.Hide();
            btnProcesar.Show();
            txtArchivo.ResetText();
            txtConsoleEdit.Show();
        }
    }

    private void ReadConsole()
    {
        lbConsole.Items.Clear();
        string[] linesData = txtConsoleEdit.Text.Split('\n');
        for(int cont = 1; cont <= linesData.Length; cont++)
        {
            lbConsole.Items.Add(cont + " ->> " + linesData[cont - 1]);
        }
        lbConsole.Enabled = true;
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
        FileUpload();
        txtArchivo.Text = ArchiveReference;
        if (txtArchivo.Text.Length > 0)
        {
            lbConsole.Enabled = true;
            ArchiveReference = "";
        }

    }

    private void FileUpload()
    {
        try
        {
            OpenFile.Filter = "Text Files(.txt)| *.txt";
            lbConsole.Items.Clear();

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                ArchiveReference = OpenFile.FileName;
                StreamReader streamReader = new StreamReader(ArchiveReference);
                int cont = 1;
                while (true)
                {
                    string actualLine = streamReader.ReadLine();
                    lbConsole.Items.Add(cont + " ->> " + actualLine);

                    if (streamReader.EndOfStream)
                    {
                        streamReader.Close();
                        break;
                    }
                    cont++;
                }
                SaveLineInFile();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }


    public void Clear()
    {
        Cache.getCache().ClearCache();
    }

    private void SaveLineInFile()
    {
        foreach (String line in txtConsoleEdit.Lines)
        {
            if (line != null)
            {
                //cache.AddLine(line);
            }
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
        txtArchivo.Text = "";
        txtConsoleEdit.Text = "";
        lbConsole.Items.Clear();
    }

    private void btnCompilar_Click(object sender, EventArgs e)
    {
        dataGridView1.Show();

        /*AnalizadorLexico anaLex = new AnalizadorLexico();

        dataGridView1.DataSource = TablaSimbolos.TablaSimbolos.ObtenerTodosSimbolos();*/



    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
