using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BGColor : MonoBehaviour
{
    public Image picture;
    public Image background;
    public Material platform;
    public Material trap;
    public Material pole;
    //public Image pictureBonusLevel, backgroundBonusLevel;

    public MeshRenderer ballRenderer;
    public List <Material> ballMaterials;

    int styleCount = 10;
    private void Start()
    {
    colorSwitcher(PlatformGenerator.level);
    }
    private void colorSwitcher(int level)
    {
        int _level;
         _level = level;
        if (_level >= styleCount) _level %= styleCount;
        
            switch (_level) {
            case 0:
                newColor(picture, 255, 255, 255);
                newColor(background, 0, 0, 0);
                newColor(platform, 255, 255, 255);
                newColor(trap, 42, 125, 124);
                newColor(pole, 135, 135, 135);
                break;

            case 1:
                 newColor(picture, 10, 20, 23);
                 newColor(background, 42, 102, 132);
                 newColor(platform, 43, 102, 132);
                 newColor(trap, 1, 46, 103);
                 newColor(pole, 156, 172, 191);
                break;
            case 2:
                newColor(picture, 43, 51, 31);
                newColor(background, 187, 200, 186);
                newColor(platform, 253, 220, 165);
                newColor(trap, 84, 103, 71);
                newColor(pole, 250, 183, 61);
                break;

            case 3:
                newColor(picture, 23, 31, 20);
                newColor(background, 180, 124, 75);
                newColor(platform, 168, 59, 36);
                newColor(trap, 86, 28, 24);
                newColor(pole, 66, 75, 54);
                break;

            case 4:
                newColor(picture, 248, 167, 62);
                newColor(background, 27, 22, 18);
                newColor(platform, 153, 153, 143);
                newColor(trap, 220, 92, 1);
                newColor(pole, 220, 92, 1);
                break;
            case 5:
                newColor(picture, 188, 184, 206);
                newColor(background, 65, 49, 67);
                newColor(platform, 145, 120, 152);
                newColor(trap, 76, 57, 79);
                newColor(pole, 213, 221, 229);
                break;
            case 6:
                newColor(picture, 121, 173, 159);
                newColor(background, 80, 49, 67);
                newColor(platform, 196, 155, 96);
                newColor(trap, 154, 83, 43);
                newColor(pole, 132, 192, 176);
                break;

            case 7:
                newColor(picture, 253, 250, 181);
                newColor(background, 182, 109, 62);
                newColor(platform, 253, 250, 181);
                newColor(trap, 74, 13, 11);
                newColor(pole, 217, 168, 81);
                break;
            case 8:
                newColor(picture, 27, 18, 16);
                newColor(background, 210, 210, 201);
                newColor(platform, 166, 105, 95);
                newColor(trap, 77, 48, 43);
                newColor(pole, 210, 210, 201);
                break;
            case 9:
                newColor(picture, 2, 51, 74);
                newColor(background, 199, 170, 188);
                newColor(platform, 144, 115, 161);
                newColor(trap, 8, 81, 115);
                newColor(pole, 184, 227, 234);
                break;
            default:
                newColor(picture, 248, 167, 62);
                newColor(background, 27, 22, 18);
                newColor(platform, 153, 153, 143);
                newColor(trap, 220, 92, 1);
                newColor(pole, 220, 92, 1);
                break;
        }
        ballRenderer.material = ballMaterials[_level];
    }


    private void newColor(Image image, float r, float g, float b)
    {
        r /= 255.0f;
        g /=  255.0f;
        b /= 255.0f;
        image.color = new Color(r, g, b);
    }

    private void newColor(Material material, float r, float g, float b)
    {
        r /= 255.0f;
        g /= 255.0f;
        b /= 255.0f;
        material.color = new Color(r, g, b);
    }



}
