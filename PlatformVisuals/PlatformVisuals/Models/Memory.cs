using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace PlatformVisuals.Models
{
    [Table("memory")]
    public class Memory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

		[MaxLength(10)]
		public int Position { get; set; }

    }

	[Table("memory_randy")]
	public class MemoryRand
	{
		[PrimaryKey,AutoIncrement]
		public int Id { get; set; }

		[MaxLength(10)]
		public int Value { get; set; }

	}

	[Table("memory_image")]
	public class TBImage
	{
		[PrimaryKey,AutoIncrement]
		public int Id { get; set; }

		[MaxLength(10)]
		public int Value { get; set; }

		[MaxLength(100)] // String com o nome da imagem.
		public string Img { get; set; }


	}

		
	//	Buscar em ordem aleatório (TESTAR)
//	SELECT foo FROM bar
//	WHERE id >= (abs(random()) % (SELECT max(id) FROM bar))
//	LIMIT 1;

}
