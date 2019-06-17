using MusicBrainz.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Persistence.Repositories
{
    /// <summary>
    /// Base Repository Class
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// _mBDbContext
        /// </summary>
        protected readonly MBDbContext _mBDbContext;

        /// <summary>
        /// Base Repository Constructor
        /// </summary>
        /// <param name="mbdbcontext"></param>
        public BaseRepository(MBDbContext mbdbcontext)
        {
            _mBDbContext = mbdbcontext;
        }
    }
}
