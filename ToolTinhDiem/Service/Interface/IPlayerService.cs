using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTinhDiem.Entity;
using ToolTinhDiem.Model;

namespace ToolTinhDiem.Service.Interface
{
	public interface IPlayerService
	{
		List<Player> GetPlayers();
		SaveResponse CreatePlayer(CreatePlayerRequest request);
	}
}
