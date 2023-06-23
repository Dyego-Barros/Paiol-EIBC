using Paiol_EIBC.Models;


namespace Paiol_EIBC;

public class UsuarioService : Usuario
{
    private readonly DatabaseContext _context;

    public UsuarioService(DatabaseContext context)
    {
        _context = context;

    }
    public void Create(Login login)
    {
        if(login != null)
        {
            var createLogin = _context.logins.Add(login);
            _context.SaveChanges();

        }else{
            throw new Exception("Error ao tentar cadastrar Usário!");
        }
    }

    public void Delete(int id, Login login)
    {
       if(id == login.id)
       {
        var deleteUser = _context.logins.Remove(login);
       _context.SaveChanges();
       

       }else{
        throw new Exception("Error ao tentar excluir Usuário");
       }

    }

    public List<Login> GetAll()
    {
        var ListUsers = _context.logins.ToList();
        return ListUsers;
    }

    public Login GetId(int id)
    {
     var user = _context.logins.Find(id);
    
       return user;
    }

    public void Update(int id, Login login)
    {
       if(id == login.id)
       {
        var edit = _context.Update(login);
        _context.SaveChanges();
       }else{
        throw new Exception("Error ao Editar usuário");
       }
    }
}

