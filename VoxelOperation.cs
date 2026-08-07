using Unity.Mathematics;
using UnityEngine;

public struct VoxelOperation
{
	public int3 origin;

	public OperationType operationType;

	public int radius;

	public int strength;

	public byte material;

	public VoxelOperation(Vector3 origin, VoxelAction action)
	{
		this.origin = (int3)((float3)origin * 256f);
		operationType = action.operation;
		radius = (int)(action.radius * 256f);
		strength = (int)(action.strength * 256f);
		material = action.material;
	}

	public bool IsValid()
	{
		if (radius > 0 && strength > 0)
		{
			if (operationType != OperationType.Add)
			{
				return operationType == OperationType.Subtract;
			}
			return true;
		}
		return false;
	}
}
