namespace AIAGlobalChangeUIModel
{
    public partial class AIAMakeConstituentInactiveUIModel
	{

		private void AIAMakeConstituentInactiveUIModel_Loaded(object sender, Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs e)
		{
            RECORDTYPEID.Value = Blackbaud.AppFx.Constituent.UIModel.GlobalChangeHelper.GetRecordTypeID("CONSTITUENT", GetRequestContext());
        }

#region "Event handlers"

		partial void OnCreated()
		{
			this.Loaded += AIAMakeConstituentInactiveUIModel_Loaded;
		}

#endregion

	}

}