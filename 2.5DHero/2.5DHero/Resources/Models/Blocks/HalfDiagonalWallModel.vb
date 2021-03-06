﻿Public Class HalfDiagonalWallModel

    Inherits BaseModel

    Public Sub New()
        vertexData.Clear()

        'This wall will start from 1 point and end at the opposite middle point diagonally


        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0), New Vector3(0, 0, 1), New Vector2(0.0, 1.0))) 'AB
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(0, 0, 1), New Vector2(1.0, 0.0))) 'H
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0), New Vector3(0, 0, 1), New Vector2(0.0, 0.0))) 'CD

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0), New Vector3(0, 0, 1), New Vector2(0.0, 1.0))) 'AB
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, -0.5), New Vector3(0, 0, 1), New Vector2(1.0, 1.0))) 'F
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(0, 0, 1), New Vector2(1.0, 0.0))) 'H

        'These will be the same triangles but from the opposite direction, this way it can be rendered from both directions or just from one direction
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0), New Vector3(0, 0, -1), New Vector2(0.0, 1.0))) 'AB
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0), New Vector3(0, 0, -1), New Vector2(0.0, 0.0))) 'CD
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(0, 0, -1), New Vector2(1.0, 0.0))) 'H

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0), New Vector3(0, 0, -1), New Vector2(0.0, 1.0))) 'AB
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(0, 0, -1), New Vector2(1.0, 0.0))) 'H
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, -0.5), New Vector3(0, 0, -1), New Vector2(1.0, 1.0))) 'F

        Me.ID = 18

        Setup()
    End Sub

End Class