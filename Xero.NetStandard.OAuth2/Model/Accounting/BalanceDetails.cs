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
    /// An array to specify multiple currency balances of an account
    /// </summary>
    [DataContract]
    public partial class BalanceDetails :  IEquatable<BalanceDetails>, IValidatableObject
    {
        
        /// <summary>
        /// The opening balances of the account. Debits are positive, credits are negative values
        /// </summary>
        /// <value>The opening balances of the account. Debits are positive, credits are negative values</value>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public double? Balance { get; set; }

        /// <summary>
        /// The currency of the balance (Not required for base currency)
        /// </summary>
        /// <value>The currency of the balance (Not required for base currency)</value>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// (Optional) Exchange rate to base currency when money is spent or received. If not specified, XE rate for the day is applied
        /// </summary>
        /// <value>(Optional) Exchange rate to base currency when money is spent or received. If not specified, XE rate for the day is applied</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceDetails {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
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
            return this.Equals(input as BalanceDetails);
        }

        /// <summary>
        /// Returns true if BalanceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencyRate != null)
                    hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
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
