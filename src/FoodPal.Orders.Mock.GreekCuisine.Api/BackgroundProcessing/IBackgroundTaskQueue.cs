using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FoodPal.Orders.Mock.GreekCuisine.Api.BackgroundProcessing
{

	public interface IBackgroundTaskQueue
	{
		void QueueBackgroundWorkItem(Func<CancellationToken, Task> workItem);

		Task<Func<CancellationToken, Task>> DequeueAsync(CancellationToken cancellationToken);
	}
}
