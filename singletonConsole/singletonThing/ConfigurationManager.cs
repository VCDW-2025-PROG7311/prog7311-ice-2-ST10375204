using System;

namespace ConfigurationManager{

    public  class ConfigurationManager{ //can make sealed> sealed means not inheritable

        private static ConfigurationManager Instance = null; //essentially holds current instance of the singelton

        public static ConfigurationManager getInstance(){
            if (Instance==null){
                Instance=new ConfigurationManager();
            }
            return Instance;
            //makes sure only the 1 instance is created and utilized
        }
        private string name="Gadget Galaxy";
        private decimal taxRate=15;
        private decimal editedtaxRate=15; //init decl
        private string currency="ZAR";

        //getters and setters...
        public string Name { get => name; set => name = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        public string Currency { get => currency; set => currency = value; }
        public decimal EditedtaxRate { get => editedtaxRate; set => editedtaxRate = value; }
    }
}