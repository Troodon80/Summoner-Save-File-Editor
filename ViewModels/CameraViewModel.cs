using SummonerSaveFileEditor.Models;
using System.ComponentModel;

public class CameraViewModel : INotifyPropertyChanged
{
    private readonly CameraBlock _camera;

    public CameraViewModel(CameraBlock camera)
    {
        _camera = camera;
    }

    public int Unknown
    {
        get => _camera.Unknown;
        set { _camera.Unknown = value; OnPropertyChanged(); }
    }

    public float FieldOfView
    {
        get => _camera.FieldOfView;
        set { _camera.FieldOfView = value; OnPropertyChanged(); }
    }

    public float Pitch
    {
        get => _camera.Pitch;
        set { _camera.Pitch = value; OnPropertyChanged(); }
    }

    public float Yaw
    {
        get => _camera.Yaw;
        set { _camera.Yaw = value; OnPropertyChanged(); }
    }

    public float Zoom
    {
        get => _camera.Zoom;
        set { _camera.Zoom = value; OnPropertyChanged(); }
    }

    public float PositionX
    {
        get => _camera.PositionX;
        set { _camera.PositionX = value; OnPropertyChanged(); }
    }

    public float PositionY
    {
        get => _camera.PositionY;
        set { _camera.PositionY = value; OnPropertyChanged(); }
    }

    public float PositionZ
    {
        get => _camera.PositionZ;
        set { _camera.PositionZ = value; OnPropertyChanged(); }
    }

    public int CameraMode
    {
        get => _camera.CameraMode;
        set { _camera.CameraMode = value; OnPropertyChanged(); }
    }

    public CameraBlock ToCameraBlock() => _camera;

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}