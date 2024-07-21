using UnityEngine;

public class ArcParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem; // 指向你的粒子系统的引用

    void Start()
    {
        var main = particleSystem.main;
        main.startSpeed = 5; // 设置粒子的起始速度
        main.startSize = 0.5f; // 设置粒子的大小
        main.maxParticles = 1000; // 设置最大粒子数

        var emission = particleSystem.emission;
        emission.rateOverTime = 50; // 每秒发射的粒子数

        var shape = particleSystem.shape;
        shape.shapeType = ParticleSystemShapeType.SingleSidedEdge; // 设置发射形状为边缘
        shape.radius = 0.1f; // 发射边缘的半径（对于边缘形状，这会影响粒子的分布）

        // 使粒子系统沿着一个弧形路径发射
        particleSystem.transform.rotation = Quaternion.Euler(-45, 0, 0); // 调整粒子系统的旋转以形成弧形路径
    }
}

