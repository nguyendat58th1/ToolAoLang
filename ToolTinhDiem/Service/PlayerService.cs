using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTinhDiem.Entity;
using ToolTinhDiem.Message;
using ToolTinhDiem.Model;
using ToolTinhDiem.Repository;
using ToolTinhDiem.Service.Interface;

namespace ToolTinhDiem.Service
{
	public class PlayerService : IPlayerService
	{
		private PlayerRepository _playerRepository;
		private StatRepository _statRepository;
		private SeasonRepository _seasonRepository;
		public PlayerService()
		{
			_playerRepository = new PlayerRepository();
			_statRepository = new StatRepository();
			_seasonRepository = new SeasonRepository();
		}

		public SaveResponse CreatePlayer(CreatePlayerRequest request)
		{
			try
			{
				var response = new SaveResponse()
				{
					IsSuccess = false
				};
				var player = _playerRepository.Get(x => x.Ten == request.Ten);
				var season = _seasonRepository.Get(x => x.Id == request.SeasonId);
				if (player != null)
				{
					response.Message = MessageResource.PlayerExisted;
					return response;
				}
				if (season == null)
				{
					response.Message = MessageResource.PlayerExisted;
					return response;
				}
				using (var tran = _playerRepository.BeginTransaction())
				{
					var newPlayer = new Player()
					{
						Ten = request.Ten
					};
					_playerRepository.Create(newPlayer);
					var stat = new Stat();
					stat.PlayerId = newPlayer.Id;
					stat.SeasonId = request.SeasonId;
					_statRepository.Create(stat);
					tran.Commit();
				}
			
				return response;
			}
			catch (Exception ex)
			{

				return new SaveResponse()
				{
					IsSuccess = false,
					Message = MessageResource.UnExpectedError
				};
			}
		}

		public List<Player> GetPlayers()
		{
			return _playerRepository.GetAll();
		}
	}
}
