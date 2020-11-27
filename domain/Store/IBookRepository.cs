using System;
using System.Collections.Generic;
using System.Text;

namespace store
{
  public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart); 
    }
}
