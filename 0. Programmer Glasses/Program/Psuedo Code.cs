using System;

namespace Program
{
    public struct Psuedo_Code
    {
        static void Main()
        {
            차량이 진입하면 시간을 기록하고,
            정기주차권을 가진 차량인지 확인한다. (새 함수)

            if (정기주차 차량이면)
            {
                차단기를 연다.(차단기 함수 구성)
            }

            else
                진입하면 시간이 찍힌 주차증을 출력. (주차증 출력 함수 구성)
                차단기를 연다.(차단기 함수 사용)
        }


        // 정기주차권 차량확인함수()
        {
            정기주차로 등록된 차량인지 확인한다.

            if(정기주차 등록 차량이면)
                정기주차 차량 확인 값을 반환.

            else
                비정기주차 차량 확인 값을 반환.
        }


        // 차단기 함수()
        {
            차단기를 연다.
        }


        // 주차권출력함수()
        {
            입차 시간이 찍힌 주차권을 출력.
        }
    }
}
