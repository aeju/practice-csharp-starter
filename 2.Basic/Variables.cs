/* 변수 선언 
* 
* 1) 자료형 변수명;
* 2) 자료형 변수명 = 값;
*/

/*이스케이프 문자(이스케이프 시퀀스) : 특별한 기능 가진 문자
 * ex. \n
 * https://learn.microsoft.com/ko-kr/cpp/c-language/escape-sequences?view=msvc-170
*/

using System;

namespace VariablesDemo
{
    class Variables
    {
        static void Main(string[] args)
        {
            string name = "최애주";
            char exmark = '!';
            sbyte age;
            age = 20;

            Console.WriteLine("Hello " + name + exmark);
            Console.Write("You are " + age + " years old" + exmark);
        }
    }
}