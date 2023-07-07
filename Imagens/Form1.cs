namespace Imagens
{
    public partial class Form1 : Form
    {
        string openedImage = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Cria um objeto da classe OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Especifica quais arquivovos são permitidos
            openFileDialog.Filter = "Imagens (JPG, GIF PNG)|*.JPG;*.GIF;*.PNG";

            //Abre a caixa de localização:
            DialogResult dialogResult = openFileDialog.ShowDialog();

            //Clicou ok
            if (dialogResult == DialogResult.OK)
            {
                //Passa o caminho da pasta
                openedImage = openFileDialog.FileName;
                //Mostra o caminho do arquivo
                lblImagePath.Text = openFileDialog.FileName;
                //Cria um bitmap a partir do arquivo
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                //Carrega o arquivo no PictureBox
                pbImage.Image = bitmap;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openedImage))
            {
                FileInfo fileInfo = new FileInfo(openedImage);

                Animal animal = new Animal();
                animal.name = "";
                animal.image = Guid.NewGuid().ToString() + fileInfo.Extension;
                bool response = animal.SaveImageToFile(openedImage, Config.imageFolder, animal.image);

                if (response)
                {
                    bool responseAdd = animal.Add(animal);

                    if (responseAdd)
                    {
                        MessageBox.Show("Gravação feita com sucesso");
                    }
                }
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal = animal.Get(1);//foto id 1
            pbLoad.Image = animal.imageBmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            dgvAnimals.DataSource = animal.GetAll();
        }
    }
}