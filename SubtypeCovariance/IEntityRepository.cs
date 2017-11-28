using SubtypeCovariance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEntityRepository<TEntity>
    where TEntity : Entity {


    TEntity GetByID(Guid id);

}

