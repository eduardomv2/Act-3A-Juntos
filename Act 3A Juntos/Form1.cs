using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_3A_Juntos
{
    public partial class Form1 : Form
    {
        // Rutas de los archivos
        private const string loansFilePath = "loans.txt"; // Archivo secuencial
        private const string authorsFilePath = "indexedAuthors.txt"; // Archivo secuencial indexado
        private const string usersFilePath = "randomUsers.bin"; // Archivo de acceso directo

        // Tamaño del registro para el archivo de acceso directo
        private const int recordSize = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            string loanInfo = txtLoanInput.Text;

            using (var writer = new StreamWriter(loansFilePath, true))
            {
                writer.WriteLine(loanInfo);
            }

            txtLoanInput.Clear();
            lblLoanOutput.Text = "Loan added.";

        }

        private void btnShowLoans_Click(object sender, EventArgs e)
        {
            if (File.Exists(loansFilePath))
            {
                string content = File.ReadAllText(loansFilePath);
                lblLoanOutput.Text = "All loans:\n" + content;
            }
            else
            {
                lblLoanOutput.Text = "Loans file does";
                lblLoanOutput.Text = "Loans file does not exist.";
            }
        }

        private void btnFindAuthor_Click(object sender, EventArgs e)
        {
            int index = (int)numAuthorIndex.Value;

            if (File.Exists(authorsFilePath))
            {
                var lines = File.ReadAllLines(authorsFilePath);
                var authorLine = lines.FirstOrDefault(line => line.StartsWith($"{index}:"));

                if (authorLine != null)
                {
                    lblAuthorOutput.Text = $"Author at index {index}: {authorLine.Split(':')[1].Trim()}";
                }
                else
                {
                    lblAuthorOutput.Text = "Author not found at this index.";
                }
            }
            else
            {
                lblAuthorOutput.Text = "Authors file does not exist.";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int index = (int)numUserIndex.Value;
            string userInfo = txtUserInput.Text;

            byte[] data = new byte[recordSize];
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(userInfo);

            Array.Copy(textBytes, data, Math.Min(recordSize, textBytes.Length));

            using (var stream = new FileStream(usersFilePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                stream.Seek(index * recordSize, SeekOrigin.Begin);
                stream.Write(data, 0, recordSize);
            }

            txtUserInput.Clear();
            lblUserOutput.Text = $"User info added at index {index}.";
        }

        private void btnReadUser_Click(object sender, EventArgs e)
        {
            int index = (int)numUserIndex.Value;

            if (File.Exists(usersFilePath))
            {
                using (var stream = new FileStream(usersFilePath, FileMode.Open, FileAccess.Read))
                {
                    stream.Seek(index * recordSize, SeekOrigin.Begin);

                    byte[] data = new byte[recordSize];
                    stream.Read(data, 0, recordSize);

                    string userInfo = System.Text.Encoding.UTF8.GetString(data).Trim('\0');

                    lblUserOutput.Text = $"User at index {index}: {userInfo}";
                }
            }
            else
            {
                lblUserOutput.Text = "Users file does not exist.";
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int index = (int)numUserIndex.Value;

            if (File.Exists(usersFilePath))
            {
                using (var stream = new FileStream(usersFilePath, FileMode.Open, FileAccess.Write))
                {
                    stream.Seek(index * recordSize, SeekOrigin.Begin);

                    byte[] emptyData = new byte[recordSize];
                    stream.Write(emptyData, 0, recordSize);

                    lblUserOutput.Text = $"Deleted user at index {index}.";
                }
            }
            else
            {
                lblUserOutput.Text = "Users file does not exist.";
            }
        }
    }
    
}
