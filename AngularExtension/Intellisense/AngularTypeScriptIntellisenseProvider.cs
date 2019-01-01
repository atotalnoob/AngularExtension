using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace AngularExtension.Intellisense
{
    [Export(typeof(IIntellisensePresenterProvider))]
    [ContentType("TypeScript")]
    [Order(Before = "default")]
    [Name("Angular TyypeScript Code Snippets")]
    class AngularTypeScriptIntellisenseProvider : IIntellisensePresenterProvider
    {
        public IIntellisensePresenter
           TryCreateIntellisensePresenter(IIntellisenseSession session)
        {

            // returning null will 
            // trigger the default Intellisense provider
            return null;
        }
    }
}
