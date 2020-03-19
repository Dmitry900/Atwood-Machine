namespace Atwood
{
    class Atwood_machine
    {
        public Instalation instalation;
        public Disk disk;
        public Thread Left_rope;
        public Thread Right_rope;
        public Body Right_body;
        public Body Leftt_body;

        public void Draw()
        {
            instalation.Draw();
            disk.Draw(instalation);
            Left_rope.Draw(instalation.Height);
            Right_rope.Draw(instalation.Height);
            Right_body.Draw(instalation.Height, Right_rope.Height);
            Leftt_body.Draw(instalation.Height, Left_rope.Height);
        }
        public Atwood_machine(float m1, float m2, float md, float inst_height)
        {
            instalation = new Instalation(inst_height);
            disk = new Disk(md);
            Left_rope = new Thread(instalation.Height, false);
            Right_rope = new Thread(instalation.Height, true);
            Right_body = new Body(m1, true);
            Leftt_body = new Body(m2, false);
        }

    }
}
