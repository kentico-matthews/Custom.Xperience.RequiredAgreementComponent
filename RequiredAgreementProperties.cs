using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace CustomFormComponent.RequiredAgreement
{

    public class RequiredAgreementProperties : FormComponentProperties<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxProperties"/> class.
        /// </summary>
        /// <remarks>
        /// The constructor initializes the base class to data type <see cref="FieldDataType.Boolean"/>.
        /// </remarks>
        public RequiredAgreementProperties() : base(FieldDataType.Boolean)
        {
        }


        /// <summary>
        /// Gets or sets the default value of the form component and underlying field.
        /// </summary>
        [DefaultValueEditingComponent(CheckBoxComponent.IDENTIFIER)]
        public override bool DefaultValue
        {
            get;
            set;
        }


        /// <summary>
        /// Represents the input value in the resulting HTML.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$kentico.formbuilder.component.checkbox.properties.text$}")]
        public string Text
        {
            get;
            set;
        }


        /// <summary>
        /// Represents a custom error message overriding the default set by the requiredagreementcomponent.notchecked resource string.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$requiredagreementcomponent.errormessage.name$}",Tooltip = "{$requiredagreementcomponent.errormessage.tooltip$}")]
        public string ErrorMessage
        {
            get;
            set;
        }


        /// <summary>
        /// Represents whether the form component is required.
        /// </summary>
        /// <remarks>
        /// Assigning no editing control means the required checkbox will not be visible.
        /// This control will always behave as if it is required regardless of this property, but returning true here will make the property consistent for anyone inspecting the component properties while debugging.
        /// </remarks>
        public override bool Required 
        {
            get => true;
            set => base.Required = value; 
        }
    }
}
