namespace PizzeriaSdomino.Writer
{
    public abstract class WriterDecorator : Writer
    {
        protected Writer _writer;
        public WriterDecorator(Writer writer)
        {
            _writer = writer;
        }
        public override void Write() => _writer.Write();
    }
}
