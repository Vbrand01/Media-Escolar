namespace Ativi_04___Sistemas_de_Média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            lblStatus.Text = "";
        }

        float n1, n2, n3, n4, media;


        private void btoOk_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtN1.Text, out n1))
            { 
            MessageBox.Show("Erro, N1 deve ser preenchido com números");
            txtN1.Text = "";
            txtN1.Focus();
            return;
            }
        if (n1 < 0 || n1 > 10)
            {
                MessageBox.Show("Erro, N1 deve ser preenchido entre 0 e 10");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }

                if (!float.TryParse(txtN2.Text, out n2))
                {
                    MessageBox.Show("Erro, N2 deve ser preenchido com números");
                    txtN2.Text = "";
                    txtN2.Focus();
                    return;
                }
                if (n2 < 0 || n2 > 10)
                {
                    MessageBox.Show("Erro, N2 deve ser preenchido entre 0 e 10");
                    txtN2.Text = "";
                    txtN2.Focus();
                    return;
                }

            if (!float.TryParse(txtN3.Text, out n3))
            {
                MessageBox.Show("Erro, N3 deve ser preenchido com números");
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }
            if (n3 < 0 || n3 > 10)
            {
                MessageBox.Show("Erro, N3 deve ser preenchido entre 0 e 10");
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }

            if (!float.TryParse(txtN4.Text, out n4))
            {
                MessageBox.Show("Erro, N4 deve ser preenchido com números");
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }
            if (n4 < 0 || n4 > 10)
            {
                MessageBox.Show("Erro, N4 deve ser preenchido entre 0 e 10");
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7)
            {
                lblStatus.Text = "Aprovado com média " + media;
            }
            else if (media < 5)
            {
                lblStatus.Text = "Reprovado com média " + media;
            }
            else
            {
                lblStatus.Text = "Exame com média " + media;
            }
        }
    }
}
