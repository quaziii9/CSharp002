namespace CSharp002
{
    /* <getter, setter>
    - 멤버 변수가 외부 객체와 상호작용하는 경우 get, set 함수를 구현해주는것이 일반적
    ㄴ get/set 함수의 접근제한자를 설정해서 외부에서 멤버변수의 접근을 캡슐화
    */

    class player
    {
        private int hp; // 프라이빗한 녀석 외부에서 접근이 불가능하다

        // 1번
        public int GetHp()  // 프라이빗한 hp를 요 녀석으로 접근
        {
            return hp;
        }

        public void SetHp(int hp)
        { this.hp = hp; } // this는 내 자신을 가리킴
        // 위 녀석은 우리가 알고 있는 게터 세터
        // 이 녀석을 간소화 시킨다면 ? 

        private int mp;

        // 2번
        public int MP               // mp멤버 변수에 get/set 속성
        {
            get { return mp; }       // get함수와 동일
            set
            {
                // if(mp<0) 하지말고 이런식으로 조건을 거는게 가능한
                // set을 하는데 다양한 조건이나 연산을 할 수 있다
                mp = value;
            }     // set함수와 동일 매개변수는 value라고 생각
        }

        // 3번
        public int AP { get; set; }     // set은 조건이 불가능
        public int BP { get; private set; } // 속성의 접근 제한자를 통한 캡슐화

        //get/set을 쓰는데 단순히 읽고 쓰는거라면
        // public int AP { get; set; } ->가 적합할 수 있고
        // 만약 뭔가가 set안에 조건이 붙거나 또는 어떤 연산이 이루어지는 거라면 
        // 1번이나 2번을 쓰는게 좋다
        class IntArray
        {
            int[] array = new int[10];

            public void SetValue(int idx, int value)
            {
                if (idx < 0 || idx > 10) return;
                array[idx] = value;
            }
        }
    }


    internal class plusclass1
    {
        static void Main(string[] args)
        {
            player player = new player();

            int hp = player.GetHp();

            Console.WriteLine(hp);

            player.SetHp(10); // 외부에 공개되어야 하니 public으로 

            hp = player.GetHp();

            Console.WriteLine(hp);
        }
    }
}
