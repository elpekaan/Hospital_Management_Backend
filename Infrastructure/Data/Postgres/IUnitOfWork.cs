using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IAppointmentRepository Appointments { get; }
    IPolyclinicRepository Polyclinics { get; }
    IPolyclinicDoctorRepository PolyclinicDoctors { get; }

    Task<int> CommitAsync();
}