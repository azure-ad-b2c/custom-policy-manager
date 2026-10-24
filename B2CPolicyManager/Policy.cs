using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace B2CPolicyManager
{
    public class Policy
    {
        public String Id { get; set; }
        public String Base { get; set; }
        public String Text { get; set; }

		public Policy( String xml )
        {
			// Get policy id and base policy id
			XDocument policyFile = XDocument.Parse( xml );
			string qualify( String name ) => $"{{{policyFile.Root.GetDefaultNamespace()}}}{name}";
			Text = xml;
			Id = policyFile.Root.Attribute( "PolicyId" ).Value;
			Base = policyFile.Root.Element( qualify( "BasePolicy" ) )?.Element( qualify( "PolicyId" ) )?.Value;
		}
	}
}
