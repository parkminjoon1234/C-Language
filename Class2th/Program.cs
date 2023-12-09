namespace Class2th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할
            // 수 없는 메모리 공간입니다.

            const int data = 999;

            // 상수는 메모리 공간을  생성하는 동시에 초기화해야 하며,
            // 한 번 저장된 값은 더 이상 변경할 수 없습니다.

            // ex) data = 100;

            // 상수의 경우 메모리 공간을 가지고 있지 않은 상수를 
            // 리터럴 상수라고 하며, 메모리 공간을 자기 왔는 상수를
            // 심블릭 상수라고 합니다.


            #endregion

            #region 조건문
            // 어떤 조건이 주어질 때 해당 조건에 따라
            // 동작을 수행하도록 실행하는 명령문입니다.


            #endregion

            #region 관계 연산자
            // 두 개의 피연산자의 값을 비교하여 그 결과를
            //0 또는 1이라는 값으로 나타내는 연산자입니다.

            // true : 참
            // false : 거짓
            //bool first = 10 < 5;
            //bool second = 10 > 5;
            //bool third = 10 <= 5;
            //bool fourth = 10 >= 5;
            //bool fifth = 10 == 5;
            //bool sixth = 10 != 5;

            //Console.WriteLine("first 변수의 값 : " + first);
            //Console.WriteLine("second 변수의 값 : " + second);
            //Console.WriteLine("third 변수의 값 : " + third);
            //Console.WriteLine("fourth 변수의 값 : " + fourth);
            //Console.WriteLine("fifth 변수의 값 : " + fifth);
            //Console.WriteLine("sixth 변수의 값 : " + sixth);


            #endregion

            #region if문
            // 어떤 특정한 조건을 비교하여 조건이 맞다면 실행되는
            // 명령문입니다.

            //int monsterHP = 100;

            //if(monsterHP <= 0)
            //{
            //    Console.WriteLine("Monster Die");
            //}

            // if문은 조건이 1일 때 실행되며, 0이면 실행되지 않습니다.
            #endregion

            #region else if문
            // if문의 조건이 틀릴 때 else if문의 조건이
            // 맞다면 실행되는 명령문입니다.

            //int level = 1;

            //if(level == 99)
            //{
            //    Console.WriteLine("승급 가능");
            //}
            //else if (level != 99)
            //{
            //    Console.WriteLine("승급 불가능");
            //}



            #endregion

            #region else문
            // if문과 else if문의 조건이 다 틀리면
            // 실행되는 명령문입니다.

            //int money = 10000;

            //if(money > 5000)
            //{
            //    Console.WriteLine("무기 구매");
            //}
            //else if(money > 2500)
            //{
            //    Console.WriteLine("소모품 구매");
            //}
            //else
            //{
            //    Console.WriteLine("금액이 부족합니다.");
            //}

            // if 문에 연결된 모든 조건문의 조건이 맞을 때
            // 가장 위에 있는 조건문만 실행됩니다.
            #endregion

            #region switch문
            // 어떤 결과에 따라 그 결과부터 실행되는
            // 명령문입니다.

            //char grade = 'A';

            //switch(grade)
            //{
            //    case 'A': Console.WriteLine("A 등급의 카드");
            //        break;
            //    case 'B': Console.WriteLine("B 등급의 카드");
            //        break;
            //    case 'C':  Console.WriteLine("C 등급의 카드");
            //        break;
            //    default : Console.WriteLine("존재하지 않은 카드");
            //        break;
            //}

            // switch문의 해당 조건이 완료되었을 때, break문이 없으면
            // 나머진 밑에 있는 case 문까지 계속 실해시키다가 종료합니다.

            #endregion

            #region 비트
            // 데이터를 나타내는 최소의 단위이며, 0 또는 1의
            // 조합으로 논리 계산을 수행하는 단위입니다.

            // [0][0][0][0][0][0][0][0]

            // 메모리는 비트 단위로 데이터를 저장할 수 있으며,
            // 1개의 비트에는 0 또는 1의 값만 저장할 수 있습니다.

            // <10진수를 2진수로 변환하는 과정>

            // 10진를 1이 될 때까지 계속 2로 나누어 준 다음
            // 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.

            // <2진수를 10진수로 변환하는 과정>
            // 1 byte에 2 진수로 저장된 값을 2의 제곱으로 나타냅니다.

            // 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한 다음
            // 각각의 비트를 모두 더하여 10 진수로 나타냅니다.
            #endregion

            #region 오버플로우
            // 특정한 자료형이 표현할 수 있는 최댓값의 범위
            // 를 넘어서 연산을 수행하는 과정입니다.

            //ex) short gas = 32768;

            #endregion

            #region 언더플로우
            // 특정한 자료형이 표현할 수 있는 최솟값의 법위를
            // 넘어서 연산을 수행하는 과정입니다.

            // ex) short mineral = -32769;


           #endregion
        }
    }
}