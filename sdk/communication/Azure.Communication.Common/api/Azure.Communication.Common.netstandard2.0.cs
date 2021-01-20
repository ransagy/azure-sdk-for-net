namespace Azure.Communication
{
    public partial class CallingApplicationIdentifier : Azure.Communication.CommunicationIdentifier
    {
        public CallingApplicationIdentifier(string id) { }
        public string Id { get { throw null; } }
        public override bool Equals(Azure.Communication.CommunicationIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class CommunicationIdentifier : System.IEquatable<Azure.Communication.CommunicationIdentifier>
    {
        protected CommunicationIdentifier() { }
        public abstract bool Equals(Azure.Communication.CommunicationIdentifier other);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
    }
    public sealed partial class CommunicationTokenCredential : System.IDisposable
    {
        public CommunicationTokenCredential(Azure.Communication.CommunicationTokenRefreshOptions tokenRefreshOptions) { }
        public CommunicationTokenCredential(string token) { }
        public void Dispose() { }
        public Azure.Core.AccessToken GetToken(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.ValueTask<Azure.Core.AccessToken> GetTokenAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CommunicationTokenRefreshOptions
    {
        public CommunicationTokenRefreshOptions(bool refreshProactively, System.Func<System.Threading.CancellationToken, string> tokenRefresher, System.Func<System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<string>>? asyncTokenRefresher, string? token = null) { }
    }
    public partial class CommunicationUserIdentifier : Azure.Communication.CommunicationIdentifier
    {
        public CommunicationUserIdentifier(string id) { }
        public string Id { get { throw null; } }
        public override bool Equals(Azure.Communication.CommunicationIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MicrosoftTeamsUserIdentifier : Azure.Communication.CommunicationIdentifier
    {
        public MicrosoftTeamsUserIdentifier(string userId, bool isAnonymous = false) { }
        public bool IsAnonymous { get { throw null; } }
        public string UserId { get { throw null; } }
        public override bool Equals(Azure.Communication.CommunicationIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PhoneNumberIdentifier : Azure.Communication.CommunicationIdentifier
    {
        public PhoneNumberIdentifier(string phoneNumber) { }
        public string PhoneNumber { get { throw null; } }
        public override bool Equals(Azure.Communication.CommunicationIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UnknownIdentifier : Azure.Communication.CommunicationIdentifier
    {
        public UnknownIdentifier(string id) { }
        public string Id { get { throw null; } }
        public override bool Equals(Azure.Communication.CommunicationIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
}
