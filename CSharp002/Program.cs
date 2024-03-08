using System;

namespace CSharp002
{

    class Test
    {
        public int num;
        public int num1;

        public Test DeepCopy()
        {
            Test newCopy = new Test();
            newCopy.num = num;
            newCopy.num1 = num1;

            return newCopy;
        }
    }

    // summary 설명
    
       /// <summary>
       /// 두 수를 더해서 결과값을 리턴하는 함수임
       /// </summary>
       /// <param name="x">첫번째 매개변수</param>
       /// <param name="y">두번째 매개변수</param>
       /// <returns></returns>
       //static int Sum(int x, int y)
       //{
       //    int result = x + y;
       //    return result;
       //}
    
    class  Person
    {
        //변수
        public string _name; // 인스턴스 필드
        public static int count;

        // 생성자
        public Person(string name) 
        {
            count++;
            _name = name;
        }
        //메서드
        public static void Output()
        {
            //Console.WriteLine(_name); // 정적 메서드 안에서는 인스턴스 필드 접근 X
        }
    }
    

    class Circle
    {
        double pi = 3.14;

        // double GetArea(double radius)
        // {
        //     return radius * radius * pi;
        // }
        // public void Print(double value) 
        //{
        //     Console.WriteLine(GetArea(value));
        // }
        // 정보은닉원칙
        // 특별한 이유를 제외하고는 필드를 절대적으로 public으로 선언 x
        // 접근이 필요할때는 접근자 / 설정자 메서드를 만들어서 외부에서 접근하는 경로를 만들면됨

        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }

    class player
    {
        // public string name { get; private set; }
        // public int health { get;  set; }
        private string _name;
        private int hp;

        public player(string name)
        {
            _name = name;
            hp = 100;
        }
        public string name { get { return _name; } }
        public int Hp 
        { 
            get { return hp; } 
            set { hp = value; }
        }    
        public void Attack(Monster m)
        {
            // 
        }
    }

    // 플레이어와 몬스터 클래스를 각각 생성
    // ㄴ 프로퍼티를 이용해서 공격을 서로 진행
    // 정보 은닉을 반드시 지킬것 -> 과제
    

   // 2. 파일 분리를 해서 해볼것 
   //  

    class Monster
    {
        private int hp;

    }

    // 상속
    class Car
    {
        protected bool engine;

        public void Break()
        {
            Console.Write("자동차가 멈춘다");
        }
        public void Accel()
        {
            Console.WriteLine("ㄱ고씽");
        }
    }

    class Truck : Car
    {
        // 메소드 오버라이드 : 필요에 의해서 부모거를 물려받아서 재정의 

        public void TruckBreak()
        {
            Break(); // 상속받은 클래스에서 부모클래스의 메서드를 호출가능
        }
        public void Move()
        {
            
            // 자식이여도 private는 안됨, protected는 자식 가능
            if(engine == true)
            {
                Break(); // 부모메서드 호출
            }
        }
        
    }
    class Suv : Car
    {
        bool engine;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Test t = new Test();
            t.num = 10;
            t.num1 = 20;

            Test b = t; // t 복사, 같은 힙 위치를 가리킴, 얕은 복사, 참조만 복사
            b.num1 = 30;
            Console.WriteLine("얕은 복사");
            Console.WriteLine("{0} , {1}", t.num, t.num1 );
            Console.WriteLine("{0} , {1}", b.num, b.num1);
            // 클래스는 : 참조형식 

            //Console.WriteLine("깊은 복사");
            //Test deepTest = new Test();
            //deepTest.num = 10;
            //deepTest.num1 = 20;

            //Test deepTest1 = deepTest.DeepCopy();
            //deepTest1.num = 30;


            //Console.WriteLine("{0} , {1}", deepTest.num, deepTest.num1);
            //Console.WriteLine("{0} , {1}", deepTest1.num, deepTest1.num1);



    //       // Person p = new Person("경일이"); // new를 통해서 인스턴스 
    //       // p.Output(); // new로 생성된 객체의 인스턴스 메서드 호출
    //       // Console.WriteLine(p._name); // new로 생성된 객체의 인스턴스 필드에 접근

    //        Person p = new Person("경일이");
    //        // Console.WriteLine(p.count);
    //        //정적 필드는 인스턴스 참조로 해서 접근 x 

    //        Person p1 = new Person("멍충이");
    //        // Console.WriteLine(p.count);
    //        // 전역적으로 값이 유지 x , static을 사용해야함
    //        Console.WriteLine(Person.count);
    //        // 메서드, 변수, 클래스도 스태틱으로 만들 수 있음 -> 전역적인애, 공용사용은 static으로 
    //        */

    //Circle circle = new Circle();

    //        Console.WriteLine(circle.Pi); // get
    //        circle.Pi = 3.5; // set
    //        Console.WriteLine(circle.Pi); // get

    //        Truck  truck = new Truck();
    //        truck.Break();
    //        truck.Accel();
    //        truck.TruckBreak();

            // private : 내부에서만 접근을 허용, 개인, 비자금
            // public : 내부, 파생클래스(자식클래스), 외부에서도 접근을 허용한다, 만인의 연인
            // portected : 내부, 그리고 내 자식에게만 접근을 허용한다. 상속관계 
            // 상속을 쓰는 이유 : 같은 기능이 있다면 , 부모한테 다 주고 확장성 용이
            // internal ,
            // internal protected 
            
        }
    }
}


 