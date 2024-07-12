
namespace IntermediateByMosh.Interfaces.Excercises;

public class WorkflowEngine(List<IActivity> workflow)
{
  private List<IActivity> Workflow { get; } = workflow;

  public void Run()
  {
    foreach (var activity in Workflow)
    {
      activity.Execute();
    }
  }

}

public class Program
{
  public static void Main(string[] args)
  {
    var workflow = new List<IActivity>
    {
        new UploadVideo(),
        new CallEncodingService(),
        new NotifyVideoOwner(),
        new UpdateVideoStatus()
    };

    var workflowEngine = new WorkflowEngine(workflow);
    workflowEngine.Run();
  }
}
