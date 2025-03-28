using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class Form1 : Form
    {
        private int findNumber = 0; //임의로 생성된 숫자가 저장될 변수
        private int chance = 0; //숫자를 맞추기 위한 횟수

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // 시작 버튼을 누르면 실행
            var rand = new Random(); //Random 클래스(임의의 수 생성 클래스), 인스턴스 변수 rand 생성
            findNumber = rand.Next(1, 21); //Next 메소드를 통해 임의의 정수 생성, 1~20 사이의 정수를 findNumber 변수에 저장
            chance = 10; // chance변수에 10 입력. 기회 10번 주어짐
            display.Text = "맞출 숫자를 입력하세요.";

        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            // 입력 버튼을 누르면 실행
            int inputNumber = Int32.Parse(textBox.Text); //문자열을 정수로 변환, textbox에는 문자열로 입력됨

            if (inputNumber == findNumber)
            {
                display.Text = "숫자 맞추기 성공!";
            }
            else
            {
                chance--;
                display.Text = "기회는  " + chance + "번 남았습니다.";
            }
            if (chance <= 0)
            {
                display.Text = "숫자 맞추기 실패!!...";
            }
               
        }
    }
}
