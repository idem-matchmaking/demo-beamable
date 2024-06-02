//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beamable.Server.Clients
{
    using System;
    using Beamable.Platform.SDK;
    using Beamable.Server;
    
    
    /// <summary> A generated client for <see cref="Beamable.Microservices.IdemMicroservice"/> </summary
    public sealed class IdemMicroserviceClient : MicroserviceClient, Beamable.Common.IHaveServiceName
    {
        
        public IdemMicroserviceClient(BeamContext context = null) : 
                base(context)
        {
        }
        
        public string ServiceName
        {
            get
            {
                return "IdemMicroservice";
            }
        }
        
        /// <summary>
        /// Call the AdminGetPlayers method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.AdminGetPlayers"/>
        /// </summary>
        public Beamable.Common.Promise<string> AdminGetPlayers(string gameId)
        {
            object raw_gameId = gameId;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("gameId", raw_gameId);
            return this.Request<string>("IdemMicroservice", "AdminGetPlayers", serializedFields);
        }
        
        /// <summary>
        /// Call the AdminGetMatches method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.AdminGetMatches"/>
        /// </summary>
        public Beamable.Common.Promise<string> AdminGetMatches(string gameId)
        {
            object raw_gameId = gameId;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("gameId", raw_gameId);
            return this.Request<string>("IdemMicroservice", "AdminGetMatches", serializedFields);
        }
        
        /// <summary>
        /// Call the AdminGetRecentPlayer method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.AdminGetRecentPlayer"/>
        /// </summary>
        public Beamable.Common.Promise<string> AdminGetRecentPlayer(string anyPlayerId)
        {
            object raw_anyPlayerId = anyPlayerId;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("anyPlayerId", raw_anyPlayerId);
            return this.Request<string>("IdemMicroservice", "AdminGetRecentPlayer", serializedFields);
        }
        
        /// <summary>
        /// Call the StartMatchmaking method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.StartMatchmaking"/>
        /// </summary>
        public Beamable.Common.Promise<string> StartMatchmaking(string gameMode, string[] servers)
        {
            object raw_gameMode = gameMode;
            object raw_servers = servers;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("gameMode", raw_gameMode);
            serializedFields.Add("servers", raw_servers);
            return this.Request<string>("IdemMicroservice", "StartMatchmaking", serializedFields);
        }
        
        /// <summary>
        /// Call the StopMatchmaking method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.StopMatchmaking"/>
        /// </summary>
        public Beamable.Common.Promise<string> StopMatchmaking()
        {
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            return this.Request<string>("IdemMicroservice", "StopMatchmaking", serializedFields);
        }
        
        /// <summary>
        /// Call the GetMatchmakingStatus method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.GetMatchmakingStatus"/>
        /// </summary>
        public Beamable.Common.Promise<string> GetMatchmakingStatus()
        {
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            return this.Request<string>("IdemMicroservice", "GetMatchmakingStatus", serializedFields);
        }
        
        /// <summary>
        /// Call the ConfirmMatch method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.ConfirmMatch"/>
        /// </summary>
        public Beamable.Common.Promise<string> ConfirmMatch(string matchId)
        {
            object raw_matchId = matchId;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("matchId", raw_matchId);
            return this.Request<string>("IdemMicroservice", "ConfirmMatch", serializedFields);
        }
        
        /// <summary>
        /// Call the CompleteMatch method on the IdemMicroservice microservice
        /// <see cref="Beamable.Microservices.IdemMicroservice.CompleteMatch"/>
        /// </summary>
        public Beamable.Common.Promise<string> CompleteMatch(string matchId, string payload)
        {
            object raw_matchId = matchId;
            object raw_payload = payload;
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            serializedFields.Add("matchId", raw_matchId);
            serializedFields.Add("payload", raw_payload);
            return this.Request<string>("IdemMicroservice", "CompleteMatch", serializedFields);
        }
    }
    
    internal sealed class MicroserviceParametersIdemMicroserviceClient
    {
        
        [System.SerializableAttribute()]
        internal sealed class ParameterSystem_String : MicroserviceClientDataWrapper<string>
        {
        }
        
        [System.SerializableAttribute()]
        internal sealed class ParameterSystem_Array_System_String : MicroserviceClientDataWrapper<string[]>
        {
        }
    }
    
    [BeamContextSystemAttribute()]
    public static class ExtensionsForIdemMicroserviceClient
    {
        
        [Beamable.Common.Dependencies.RegisterBeamableDependenciesAttribute()]
        public static void RegisterService(Beamable.Common.Dependencies.IDependencyBuilder builder)
        {
            builder.AddScoped<IdemMicroserviceClient>();
        }
        
        public static IdemMicroserviceClient IdemMicroservice(this Beamable.Server.MicroserviceClients clients)
        {
            return clients.GetClient<IdemMicroserviceClient>();
        }
    }
}