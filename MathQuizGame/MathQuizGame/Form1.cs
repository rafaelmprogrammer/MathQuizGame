//Aplica��o de desafios com opera��es matem�ticas 

namespace MathQuizGame
{
    public partial class Form1 : Form
    {
        // Declara��o do objeto random e das vari�veis 
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
            //Inicializ��o da interface de utilizador
            InitializeComponent();
        }

        //M�todo que inicia o quiz
        public void StartTheQuiz()
        {
            //Gera dois n�mero aleat�rio para o problema da soma guardando esses dois valores
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Converte os dois valores em strings para serem mostradas na label 
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //assume o valor 0 para a vari�vel sum no controlo de NumericUpDown
            sum.Value = 0;

            // Preenche o problema da subtra��o com dois n�mero aleat�rios e convers�o das vari�veis int para string de forma a serem mostradas na label
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Preenche o problema da multiplica��o com dois n�mero aleat�rios e convers�o das vari�veis int para string de forma a serem mostradas na label
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Preenche o problema da divis�o com dois n�mero aleat�rios e convers�o das vari�veis int para string de forma a serem mostradas na label
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Inicia a contagem decrescente do tempo pr�-estabelcido como 40 segundos
            timeLeft = 40;
            timeLabel.Text = "40 seconds";
            timer1.Start();
        }

        //M�todo para o bot�o de start e que depois de iniciado o quiz o utilizador n�o o pode encerrar antes de estar terminado
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        //verifica��o se as respostas est�o corretas ou erradas
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
            //caso o utilizador tenha acertado as respostas e caso estejam dentro do tempo estipulado � mostrada uma mensagem 

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            //caso as respostas n�o estejam certas o tempo continua a diminuir 
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            //se o tempo terinar e as respostas n�o estejam certas � mostrada uma mensagem informativa ao utilizador 
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

       //M�todo para o clicar enter em todos os NumericUpDown 
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
