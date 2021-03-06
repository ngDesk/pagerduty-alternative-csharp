/* 
 * ngDesk_Operations
 *
 * ngDesk_Operations
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// TicketPremadeResponse
    /// </summary>
    [DataContract]
    public partial class TicketPremadeResponse :  IEquatable<TicketPremadeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketPremadeResponse" /> class.
        /// </summary>
        /// <param name="TICKET_PREMADE_RESPONSE_ID">TICKET_PREMADE_RESPONSE_ID.</param>
        /// <param name="BODY">BODY.</param>
        /// <param name="TITLE">TITLE.</param>
        /// <param name="COMPANY_ID">COMPANY_ID.</param>
        /// <param name="USER_ID">USER_ID.</param>
        public TicketPremadeResponse(int? TICKET_PREMADE_RESPONSE_ID = default(int?), string BODY = default(string), string TITLE = default(string), int? COMPANY_ID = default(int?), int? USER_ID = default(int?))
        {
            this.TICKET_PREMADE_RESPONSE_ID = TICKET_PREMADE_RESPONSE_ID;
            this.BODY = BODY;
            this.TITLE = TITLE;
            this.COMPANY_ID = COMPANY_ID;
            this.USER_ID = USER_ID;
        }
        
        /// <summary>
        /// Gets or Sets TICKET_PREMADE_RESPONSE_ID
        /// </summary>
        [DataMember(Name="TICKET_PREMADE_RESPONSE_ID", EmitDefaultValue=false)]
        public int? TICKET_PREMADE_RESPONSE_ID { get; set; }

        /// <summary>
        /// Gets or Sets BODY
        /// </summary>
        [DataMember(Name="BODY", EmitDefaultValue=false)]
        public string BODY { get; set; }

        /// <summary>
        /// Gets or Sets TITLE
        /// </summary>
        [DataMember(Name="TITLE", EmitDefaultValue=false)]
        public string TITLE { get; set; }

        /// <summary>
        /// Gets or Sets COMPANY_ID
        /// </summary>
        [DataMember(Name="COMPANY_ID", EmitDefaultValue=false)]
        public int? COMPANY_ID { get; set; }

        /// <summary>
        /// Gets or Sets USER_ID
        /// </summary>
        [DataMember(Name="USER_ID", EmitDefaultValue=false)]
        public int? USER_ID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TicketPremadeResponse {\n");
            sb.Append("  TICKET_PREMADE_RESPONSE_ID: ").Append(TICKET_PREMADE_RESPONSE_ID).Append("\n");
            sb.Append("  BODY: ").Append(BODY).Append("\n");
            sb.Append("  TITLE: ").Append(TITLE).Append("\n");
            sb.Append("  COMPANY_ID: ").Append(COMPANY_ID).Append("\n");
            sb.Append("  USER_ID: ").Append(USER_ID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TicketPremadeResponse);
        }

        /// <summary>
        /// Returns true if TicketPremadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TicketPremadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketPremadeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TICKET_PREMADE_RESPONSE_ID == other.TICKET_PREMADE_RESPONSE_ID ||
                    this.TICKET_PREMADE_RESPONSE_ID != null &&
                    this.TICKET_PREMADE_RESPONSE_ID.Equals(other.TICKET_PREMADE_RESPONSE_ID)
                ) && 
                (
                    this.BODY == other.BODY ||
                    this.BODY != null &&
                    this.BODY.Equals(other.BODY)
                ) && 
                (
                    this.TITLE == other.TITLE ||
                    this.TITLE != null &&
                    this.TITLE.Equals(other.TITLE)
                ) && 
                (
                    this.COMPANY_ID == other.COMPANY_ID ||
                    this.COMPANY_ID != null &&
                    this.COMPANY_ID.Equals(other.COMPANY_ID)
                ) && 
                (
                    this.USER_ID == other.USER_ID ||
                    this.USER_ID != null &&
                    this.USER_ID.Equals(other.USER_ID)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TICKET_PREMADE_RESPONSE_ID != null)
                    hash = hash * 59 + this.TICKET_PREMADE_RESPONSE_ID.GetHashCode();
                if (this.BODY != null)
                    hash = hash * 59 + this.BODY.GetHashCode();
                if (this.TITLE != null)
                    hash = hash * 59 + this.TITLE.GetHashCode();
                if (this.COMPANY_ID != null)
                    hash = hash * 59 + this.COMPANY_ID.GetHashCode();
                if (this.USER_ID != null)
                    hash = hash * 59 + this.USER_ID.GetHashCode();
                return hash;
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
