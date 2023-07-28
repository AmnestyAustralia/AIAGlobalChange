namespace AIAGlobalChangeUIModel
{

	public partial class AIAUpdateRevenueMetadataUIModel
	{

		private void AIAUpdateRevenueMetadataUIModel_Loaded(object sender, Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs e)
		{
            RECORDTYPEID.Value = Blackbaud.AppFx.Constituent.UIModel.GlobalChangeHelper.GetRecordTypeID("REVENUE", GetRequestContext());
        }

        #region "Event handlers"

        partial void OnCreated()
		{
			this.Loaded += AIAUpdateRevenueMetadataUIModel_Loaded;
		}

#endregion

	}

}