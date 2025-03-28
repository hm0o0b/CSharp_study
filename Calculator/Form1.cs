using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None; //현재 선택된 연산자를 저장하는 변수. None -> 연산자 아직 선택되지 않은상태
        Boolean operatorChangeFlag = false; // 연산자 입력 후 새로운 숫자 입력할 때 기존 숫자를 지우기 위한 flag
        int firstNumber = 0; //첫번째 숫자
        int secondNumber = 0; //두번째 숫자

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e) // = 결과버튼 누를 때  
        {
            secondNumber = Int32.Parse(display.Text); //두번째 숫자를 숫자로 변환

            //입력받은 연산자가 +, -, x, / 일경우 
            if (currentOperator == Operators.Add)
            {
                firstNumber += secondNumber;
                display.Text = firstNumber.ToString(); //+ 눌렀을 경우 첫번째+두번째 숫자 -> 결과값을 첫번째 숫자에 저장
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstNumber -= secondNumber;
                display.Text = firstNumber.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstNumber *= secondNumber;
                display.Text = firstNumber.ToString();
            }
            else if (currentOperator == Operators.Divide) //두번째 값이 0인경우 계산 불가
            {
                if (secondNumber == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstNumber /= secondNumber;
                    display.Text = firstNumber.ToString();
                }
            }

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true; // 연산자 눌릴때마다 true값으로 설정되어야함. 출력된값 지우고 다시 숫자를 출력
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;

        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e) // 모든 값을 초기화
        {
            firstNumber = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, EventArgs e) // 0 클릭했을때 
        {
            if(operatorChangeFlag == true) //사용자가 방금 연산자를 누른 상태 
            {
                display.Text = ""; // 그러니까 연산자를 누른다음(flag값이 true)에 0을 누를려면 이전 숫자(firstNumber)는 지워야함
                operatorChangeFlag= false;
            }
            string strNumber = display.Text += 0; // 기존 숫자 뒤에 0 추가
            int intNumber = Int32.Parse(strNumber); //정수로 변환. 앞의 0 제거
            display.Text = intNumber.ToString(); //다시 문자열로 변환해서 표시
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false; 
            }
            string strNumber = display.Text += "1"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) //새로운 숫자 입력해야함. display.Text초기화 ""해줌
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9"; // 1을 입력하면 문자열이 strNumber 변수에 저장 (1=문자열)
            int intNumber = Int32.Parse(strNumber); // 문자열을 정수, 숫자1로 변환
            display.Text = intNumber.ToString(); // label, textbox는 문자열. 숫자에서 다시 문자열로 변환
        }
    }
}
