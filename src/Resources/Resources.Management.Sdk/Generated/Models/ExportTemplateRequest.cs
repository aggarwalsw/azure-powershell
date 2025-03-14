// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Export resource group template request parameters.
    /// </summary>
    public partial class ExportTemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>
        public ExportTemplateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>

        /// <param name="resources">The IDs of the resources to filter the export by. To export all resources,
        /// supply an array with single entry &#39;*&#39;.
        /// </param>

        /// <param name="options">The export template options. A CSV-formatted list containing zero or more
        /// of the following: &#39;IncludeParameterDefaultValue&#39;, &#39;IncludeComments&#39;,
        /// &#39;SkipResourceNameParameterization&#39;, &#39;SkipAllParameterization&#39;
        /// </param>

        /// <param name="outputFormat">The output format for the exported resources.
        /// Possible values include: &#39;Json&#39;, &#39;Bicep&#39;</param>
        public ExportTemplateRequest(System.Collections.Generic.IList<string> resources = default(System.Collections.Generic.IList<string>), string options = default(string), string outputFormat = default(string))

        {
            this.Resources = resources;
            this.Options = options;
            this.OutputFormat = outputFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the IDs of the resources to filter the export by. To export
        /// all resources, supply an array with single entry &#39;*&#39;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.IList<string> Resources {get; set; }

        /// <summary>
        /// Gets or sets the export template options. A CSV-formatted list containing
        /// zero or more of the following: &#39;IncludeParameterDefaultValue&#39;,
        /// &#39;IncludeComments&#39;, &#39;SkipResourceNameParameterization&#39;,
        /// &#39;SkipAllParameterization&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "options")]
        public string Options {get; set; }

        /// <summary>
        /// Gets or sets the output format for the exported resources. Possible values include: &#39;Json&#39;, &#39;Bicep&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputFormat")]
        public string OutputFormat {get; set; }
    }
}