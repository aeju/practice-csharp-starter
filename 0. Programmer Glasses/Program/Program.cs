/*
 * 순서도 : 작업의 순서를 나타내는 다이어그램 (프로그램 설계 , 문서화)
 * 
 * 순서도 작성 사이트 
 * 1. draw.io
 * 2. google drawings (docs.google.com/drawings)
 */

using System;

namespace ParkingSystem
{
    class Program
    {
        // 차량이 진입하면 시간을 기록하고,
        // 정기주차권을 가진 차량인지 확인한다.
        static void Main()
        {
            // 차량이 진입하면 시간을 기록하고 
            string timeIn = DateTime.Now.ToString("yyyy-mm-dd:mm:ss");

            // 정기주차권을 가진 차량인지 확인한다.(새 함수 구)
            int RegularParking = CheckRegularParking();

            // if(정기주차 차량이면)
            if (RegularParking == 1)
            {
                // 차단기를 연다. (차단기 함수 구성)
                GateOpen();
            }

            // 정기주차 차량이 아니면 
            else
            {
                // 진입 시간이 찍힌 주차증을 출력. (주차증 출력 함수 구성)
                PrintTicket(timeIn);

                // 차단기를 연다. (차단기 함수 사용)
                GateOpen();
            }
        }

        // 정기주차권 차량확인함수()
        static int CheckRegularParking()
        {
            // 정기주차로 등록된 차량인지 확인.
            int result;
            bool IsRegistered = false;

            // if(정기주차 등록 차량이면)
            if (IsRegistered == true)
            {
                // 정기주차 차량 확인 값을 반환.
                result = 1;
                return result;
            }

            // 정기주차 등록 차량이 아니면
            else
            {
                // 비정기주차 차량 확인 값을 반환.
                result = 2;
                return result;
            }
        }

        // 차단기 함수()
        static void GateOpen()
        {
            // 차단기를 연다.
            Console.WriteLine("차단기가 열립니다");
        }

        // 주차권 출력 함수()
        static void PrintTicket(string time)
        {
            // 입차 시간이 찍힌 주차권을 출력.
            Console.WriteLine("입차시간: {0}", time);
        }
    }
}