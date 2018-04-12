using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.TestProg
{
    using System;
    using System.Collections.Generic;

    public class DocumentStore
    {
        private readonly List<string> documents = new List<string>();
        private int capacity;

        public DocumentStore(int capacity)
        {
            this.capacity = capacity;
        }

        public int Capacity { get { return capacity; } }

        public IEnumerable<string> Documents
        {
            get;
            set;
        }

        public void AddDocument(string document)
        {
            if (documents.Count >= capacity)
                throw new InvalidOperationException();

            documents.Add(document);
        }

        public override string ToString()
        {
            return String.Format("Document store: {0}/{1}", documents.Count, capacity);
        }
    }

  
}
