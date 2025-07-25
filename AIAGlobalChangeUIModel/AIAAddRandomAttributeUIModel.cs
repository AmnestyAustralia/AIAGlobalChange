using System;
using Blackbaud.AppFx.Constituent.UIModel;
using Blackbaud.AppFx.UIModeling.Core;

namespace AIAGlobalChangeUIModel
{

	public partial class AIAAddRandomAttributeUIModel
	{
    private void _recordtypeid_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      if (!this.Loading)
      {
        ATTRIBUTECATEGORYID.Value = Guid.Empty;
        IDSETREGISTERID.Value = Guid.Empty;
      }
      ATTRIBUTECATEGORYID.ResetDataSource();
      IDSETREGISTERID.UpdateDisplayText();
    }

		private void AIAAddRandomAttributeUIModel_Loaded(object sender, Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs e)
		{
      if (!RECORDTYPEID.HasValue())
      {
        RECORDTYPEID.Value = GlobalChangeHelper.GetRecordTypeID("CONSTITUENT", GetRequestContext());
      }
    }

    private void AIAAddRandomAttributeUIModel_BeginValidate(object sender, BeginValidateEventArgs e)
    {
      if (DateTime.Compare(STARTDATE.Value, DateTime.MinValue) != 0 && DateTime.Compare(ENDDATE.Value, DateTime.MinValue) != 0 && DateTime.Compare(STARTDATE.Value, ENDDATE.Value) > 0)
      {
        e.Valid = false;
        e.InvalidFieldName = "ENDDATE";
        e.InvalidReason = "The start date value must be on or before the end date value.";
      }

      if (RANDMAXVALUE.Value < RANDMINVALUE.Value)
      {
        e.Valid = false;
        e.InvalidFieldName = "RANDMAXVALUE";
        e.InvalidReason = "The maximum value must be greater than or equal to the minimum value.";
      }

      if (RANDMINVALUE.Value > RANDMAXVALUE.Value)
      {
        e.Valid = false;
        e.InvalidFieldName = "RANDMINVALUE";
        e.InvalidReason = "The minimum value must be less than or equal to the maximum value.";
      }
    }


    #region "Event handlers"

    partial void OnCreated()
		{
			this.Loaded += AIAAddRandomAttributeUIModel_Loaded;
      this.BeginValidate += AIAAddRandomAttributeUIModel_BeginValidate;
      this._recordtypeid.ValueChanged += _recordtypeid_ValueChanged;
		}

#endregion

	}

}