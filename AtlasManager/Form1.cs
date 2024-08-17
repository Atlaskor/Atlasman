using System.Diagnostics;
using System.IO;
using System.Text;

namespace AtlasManager
{
    public partial class AtlasManager : Form
    {
        public AtlasManager()
        {
            InitializeComponent();
        }


        string servicepath = @"C:\AtlasManager\Services.txt";
        string userpath = @"C:\AtlasManager\Users.txt";
        string passpath = @"C:\AtlasManager\Pass.txt";
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserBox.Items.Add(UsernameBox.Text);
            PassBox.Items.Add(PasswordBox.Text);
            ServiceBox.Items.Add(ServicesBox.Text);
        }
        public void ImportTables(string path, int i)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);
                //Read the first line of text
                string line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    if (i == 0)
                    {
                        ServiceBox.Items.Add(line);
                        line = sr.ReadLine();
                    }
                    if (i == 1)
                    {
                        UserBox.Items.Add(line);
                        line = sr.ReadLine();
                    }
                    if (i == 2)
                    {
                        PassBox.Items.Add(line);
                        line = sr.ReadLine();
                    }
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public void addservitems(string item)
        {
            ServiceBox.Items.Add(item);
        }
        public void WriteTables()
        {
            int serviceruns = ServiceBox.Items.Count;
            int userruns = UserBox.Items.Count;
            int passruns = PassBox.Items.Count;
            FileStream stream;
            try
            {
                // Create a FileStream with mode CreateNew
                stream = new FileStream(servicepath, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (string line in ServiceBox.Items)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
            }
            finally { }
            try
            {
                // Create a FileStream with mode CreateNew
                stream = new FileStream(userpath, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (string line in UserBox.Items)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
            }
            finally { }
            try
            {
                // Create a FileStream with mode CreateNew
                stream = new FileStream(passpath, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (string line in PassBox.Items)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
            }
            finally { }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            WriteTables();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            ServiceBox.Items.Clear();
            UserBox.Items.Clear();
            PassBox.Items.Clear();
            ImportTables(servicepath, 0);
            ImportTables(userpath, 1);
            ImportTables(passpath, 2);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
                CopyUserBox.Text = UserBox.SelectedItem.ToString();
                CopyPassBox.Text = PassBox.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PassHide_CheckedChanged(object sender, EventArgs e)
        {
            if (PassHide.Checked == true)
            {
                PassBox.Visible = false;
            }
            if (PassHide.Checked == false)
            {
                PassBox.Visible = true;
            }
        }
    }
}