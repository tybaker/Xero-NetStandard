/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.8.4
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// CISSetting
    /// </summary>
    [DataContract]
    public partial class CISSetting :  IEquatable<CISSetting>, IValidatableObject
    {
        
        /// <summary>
        /// Boolean that describes if the contact is a CIS Subcontractor
        /// </summary>
        /// <value>Boolean that describes if the contact is a CIS Subcontractor</value>
        [DataMember(Name="CISEnabled", EmitDefaultValue=false)]
        public bool? CISEnabled { get; set; }

        /// <summary>
        /// CIS Deduction rate for the contact if he is a subcontractor. If the contact is not CISEnabled, then the rate is not returned
        /// </summary>
        /// <value>CIS Deduction rate for the contact if he is a subcontractor. If the contact is not CISEnabled, then the rate is not returned</value>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public decimal? Rate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CISSetting {\n");
            sb.Append("  CISEnabled: ").Append(CISEnabled).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CISSetting);
        }

        /// <summary>
        /// Returns true if CISSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of CISSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CISSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CISEnabled == input.CISEnabled ||
                    (this.CISEnabled != null &&
                    this.CISEnabled.Equals(input.CISEnabled))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CISEnabled != null)
                    hashCode = hashCode * 59 + this.CISEnabled.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
