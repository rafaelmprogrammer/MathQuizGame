//Aplicação de desafios com operações matemáticas 

namespace MathQuizGame
{
    public partial class Form1 : Form
    {
        // Declaração do objeto random e das variáveis 
        private Random randomizer = new Random();
        private int addend1;
        private int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            //Inicializção da interface de utilizador
            InitializeComponent();
        }

        //Método que inicia o quiz
        public void StartTheQuiz()
        {
            //Gera dois número aleatório para o problema da soma guardando esses dois valores
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Converte os dois valores em strings para serem mostradas na label 
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //assume o valor 0 para a variável sum no controlo de NumericUpDown
            sum.Value = 0;

            // Preenche o problema da subtração com dois número aleatórios e conversão das variáveis int para string de forma a serem mostradas na label
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Preenche o problema da multiplicação com dois número aleatórios e conversão das variáveis int para string de forma a serem mostradas na label
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Preenche o problema da divisão com dois número aleatórios e conversão das variáveis int para string de forma a serem mostradas na label
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Inicia a contagem decrescente do tempo pré-estabelcido como 40 segundos
            timeLeft = 40;
            timeLabel.Text = "40 seconds";
            timer1.Start();
        }

        //Método para o botão de start e que depois de iniciado o quiz o utilizador não o pode encerrar antes de estar terminado
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        //verificação se as respostas estáo corretas ou erradas
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //caso o utilizador tenha acertado as respostas e caso estejam dentro do tempo estipulado é mostrada uma mensagem 

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            //caso as respostas não estejam certas o tempo continua a diminuir 
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            //se o tempo terinar e as respostas não estejam certas é mostrada uma mensagem informativa ao utilizador 
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            
        }

       //Método para o clicar enter em todos os NumericUpDown 
        private void answer_enter(object sender, EventArgs e)
        {
            // Seleciona as respostas nos NumericUpDown
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
