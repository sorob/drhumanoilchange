public class Service : IService
{
	public void DoWork()
	{
	}

	void IService.DoWork()
	{
		//ILSpy generated this explicit interface implementation from .override directive in DoWork
		this.DoWork();
	}
}
