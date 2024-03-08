namespace CSharp002
{
    // 상속 (Inheritance)
    // ====================================================
    /*
     부모 클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
    부모 클래스를 상속하는 자식클래스에서 부모클래스의 모든 기능을 부여 
    class 자식 클래스 : 부모 클래스
    상속이라는 관계를 찾다보면 ... is ~ a 관계라는게 튀어나온다.
    사과는 과일이다 그럼 상속

    */
    // ====================================================

    internal class plusclass2
    {
        class Monster
        {
            // private int hp;
            protected string name;
            protected int hp;

            public void Move()
            {
                Console.WriteLine($"{name}이/가 움직입니다");
            }
            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name}이/가 {damage}받아 체력이 {hp}가 되었습니다");
            }
        }
        class Dragone : Monster
        {
            public Dragone()
            {
                name = "드래곤";
                hp = 100;
            }
            public Dragone(string str) // 오버로딩을 해도됨 
            {
                name = str;
                hp = 100;
            }

            public void Breath()
            {
                Console.WriteLine($"{name}이/가 과도한 음주로 인해 브레스를 뿜습니다.");
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 5;
            }
            public void Split()
            {
                Console.WriteLine($"{name}이/가 분열합니다.");
            }
        }

        class Hero
        {
            int damage = 3;
            public void Attack(Monster monster)
            {
                monster.TakeHit(damage);
            }

        }
        static void Main(string[] args)
        {
            Dragone dragon = new Dragone();
            Dragone dragon2 = new Dragone("드래고오온");
            Slime slime = new Slime();

            // 부모 클래스 monster를 상속한 자식 클래스는 모두 부모 클래스의 기능을 가지고 있다는 뜻
            dragon.Move();
            slime.Move();

            // 자식클래스는 부모클래스의 기능에 자식만의 기능을 추가해서 구현 가능
            dragon.Breath();
            slime.Split();

            Hero hero = new Hero();
            hero.Attack(dragon);
            hero.Attack(slime);
        }
    }
}
