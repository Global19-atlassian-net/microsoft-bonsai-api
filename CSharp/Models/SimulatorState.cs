// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SimulatorState
    {
        /// <summary>
        /// Initializes a new instance of the SimulatorState class.
        /// </summary>
        public SimulatorState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimulatorState class.
        /// </summary>
        public SimulatorState(string sessionId = default(string), int? sequenceId = default(int?), object state = default(object), bool? halted = default(bool?), string error = default(string))
        {
            SessionId = sessionId;
            SequenceId = sequenceId;
            State = state;
            Halted = halted;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequenceId")]
        public int? SequenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public object State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "halted")]
        public bool? Halted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

    }
}
