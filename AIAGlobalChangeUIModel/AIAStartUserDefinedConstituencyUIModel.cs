namespace AIAGlobalChangeUIModel
{

	public partial class AIAStartUserDefinedConstituencyUIModel
	{

		private void AIAStartUserDefinedConstituencyUIModel_Loaded(object sender, Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs e)
		{
            RECORDTYPEID.Value = Blackbaud.AppFx.Constituent.UIModel.GlobalChangeHelper.GetRecordTypeID("CONSTITUENT", GetRequestContext());
		}

#region "Event handlers"

		partial void OnCreated()
		{
			this.Loaded += AIAStartUserDefinedConstituencyUIModel_Loaded;
		}

#endregion

	}

}