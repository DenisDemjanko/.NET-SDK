namespace BackendlessAPI.Test.PersistenceService.AsyncEntities.FindEntities
{
  public class FindWithPageSizeAndOffsetEntityAsync : BaseFindEntityAsync
  {
    public override bool Equals( object obj )
    {
      if( ReferenceEquals( null, obj ) )
        return false;
      if( ReferenceEquals( this, obj ) )
        return true;
      if( obj.GetType() != this.GetType() )
        return false;
      return Equals( (FindWithPageSizeAndOffsetEntityAsync) obj );
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
