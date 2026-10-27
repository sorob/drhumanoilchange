using System.ServiceModel;

[ServiceContract]
public interface IService
{
	[OperationContract]
	void DoWork();
}
