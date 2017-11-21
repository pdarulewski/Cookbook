using iTextSharp.text;
using System;
using System.Collections.Generic;

namespace Cookbook
{
    class PdfCreator
    {
        internal Recipe Recipe
        {
            get => default(Cookbook.Recipe);
            set
            {
            }
        }

        private Document createDocument(Recipe recipe)
        {
            return new Document();
        }


    }
}
