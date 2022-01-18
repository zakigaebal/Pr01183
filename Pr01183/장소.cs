namespace Pr01183
{
    public class 장소
    {
        public string 이름 { get; set; }

        public 사람[] 이용자들 { get; set; }

        public string 이용자추가(사람 손님)
        {
            string 이용자명단 = "";

            //1.이용자를 가장 첫번째 빈공간에 추가하는 루프
            for(int index=0; index<이용자들.Length; index++)
                if(이용자들[index] == null)
                {
                    이용자들[index] = 손님;
                    break;
                }
            //2.이용자들의 리스트를 만드는 루프
            foreach (사람 사람이름 in 이용자들)
                if (사람이름 == null)
                    break;
                else
                    이용자명단 += 사람이름.이름 + ",";

            return 이용자명단;
        }
    }
}