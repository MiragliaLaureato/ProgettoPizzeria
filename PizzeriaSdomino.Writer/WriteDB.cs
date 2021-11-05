namespace PizzeriaSdomino.Writer
{
    public class WriteDB : WriterDecorator
    {
        public WriteDB(Writer writer) : base(writer)
        {
            _writer = writer;
        }
        public override void Write()
        {
        }

    }
}
