namespace BlazorWasmTest.Models
{
    public record LoginResponse
    {
        public string Token { get; init; }
        public string RefreshToken { get; init; }
        public User User { get; init; }
    }
}
