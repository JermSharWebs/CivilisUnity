using AqlaSerializer;
using Neolithica.MonoBehaviours.Logistics;

namespace Tofu.Serialization.Surrogates {
    [SerializableType, SurrogateFor(typeof(LogisticsNode))]
    public class LogisticsNodeSurrogate {

        [SerializableMember(1)] public MonoBehaviourResolver Resolver { get; set; }
        [SerializableMember(2)] public LogisticsManager LogisticsLogisticsManager { get; set; }
        [SerializableMember(3)] public LogisticsNetwork LogisticsNetwork { get; set; }

        public static implicit operator LogisticsNodeSurrogate(LogisticsNode value) {
            if (value == null)
                return null;

            return new LogisticsNodeSurrogate {
                Resolver = MonoBehaviourResolver.Make(value),
                LogisticsLogisticsManager = value.LogisticsLogisticsManager,
                LogisticsNetwork = value.LogisticsNetwork,
            };
        }

        public static implicit operator LogisticsNode(LogisticsNodeSurrogate surrogate) {
            if (surrogate == null)
                return null;

            LogisticsNode x = surrogate.Resolver.Resolve<LogisticsNode>();
            x.LogisticsLogisticsManager = surrogate.LogisticsLogisticsManager;
            x.LogisticsNetwork = surrogate.LogisticsNetwork;

            return x;
        }
    }
}
