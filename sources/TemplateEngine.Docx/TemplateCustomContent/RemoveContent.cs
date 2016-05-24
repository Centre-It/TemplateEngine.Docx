namespace TemplateEngine.Docx
{
	public class RemoveContent : IContentItem
    {
        public RemoveContent()
        {
            
        }

        public RemoveContent(string name, RemoveContentOptions options = null)
        {
            Name = name;
            Options = options
                ?? new RemoveContentOptions();
        }
   
        public string Name { get; set; }
        public RemoveContentOptions Options { get; }
    }
}
