using System;
using System.Threading;

namespace Pr01183
{
    public class 사람
    {
        public string 이름 { get; set; }

        public 장소 현재위치 { get; set; }

        public void 이동하다(장소 이동장소)
        {
            this.현재위치 = 이동장소;
            string 이용자명단 = 이동장소.이용자추가(this);
            Console.WriteLine(this.이름 + "님이" + 이동장소.이름 + "으로 이동하셨습니다.");
            Console.WriteLine(이동장소.이름 + "현재이용자" + 이용자명단);
            Thread.Sleep(1000);
        }

        public void 말하다(string 대사)
        {
            Console.WriteLine(this.이름 + ":" + 대사);
            Thread.Sleep(1000);
        }

        public static void 단체이동(장소 이동장소, 사람[] 이동자들)
        {
            foreach(사람 이동자 in 이동자들)
            {
                이동자.현재위치 = 이동장소;
                string 이동자명단 = 이동장소.이용자추가(이동자);
                Console.WriteLine(이동자.이름 + "님이" + 이동장소.이름 + "으로 이동하셨습니다.");
                Console.WriteLine(이동장소.이름 + "의 현재 이용자:" + 이동자명단);
                Thread.Sleep(1000);
            }
        }
    }
}