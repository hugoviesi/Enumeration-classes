namespace EnumerationClasses.Enum
{
    public abstract class EmployeeType : Enumeration
    {
        public static readonly EmployeeType Manager
        = new ManagerType();
        public static readonly EmployeeType Servant
            = new ServantType();
        public static readonly EmployeeType AssistantToTheRegionalManager
            = new AssistantToTheRegionalManagerType();

        private EmployeeType() { }
        private EmployeeType(int value, string displayName) : base(value, displayName) { }

        public abstract decimal BonusSize { get; }

        private class ManagerType : EmployeeType
        {
            public ManagerType() : base(0, "Manager") { }

            public override decimal BonusSize
            {
                get { return 1000m; }
            }
        }

        private class ServantType : EmployeeType
        {
            public ServantType() : base(1, "Servant") { }

            public override decimal BonusSize
            {
                get { return 500m; }
            }
        }

        private class AssistantToTheRegionalManagerType : EmployeeType
        {
            public AssistantToTheRegionalManagerType() : base(2, "AssistantToTheRegionalManager") { }

            public override decimal BonusSize
            {
                get { return 800m; }
            }
        }
    }
}
