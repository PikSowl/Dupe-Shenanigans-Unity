using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class SimonSystem : MonoBehaviour
{
    public GameObject NotBG;

    public GameObject ReturnButton;
    public GameObject StartButton;
    public TMP_Text InfoText;
    public TMP_Text ScoreText;
    public TMP_Text HiScoreText;

    public Button GreenButton;
    public Button YellowButton;
    public Button BlueButton;
    public Button RedButton;


    // Time between shown buttons in seconds
    public float timeToSee;

    public int hiScore;

    private List<Button> buttons = new List<Button>();
    private List<string> buttonNames = new List<string>();
    private List<int> sequence = new List<int>();
    private int curentIndex;


    private void Start()
    {
        buttons.Add(GreenButton);
        buttons.Add(YellowButton);
        buttons.Add(BlueButton);
        buttons.Add(RedButton);
        DisableButtons();

        hiScore = YG2.saves.simonHiScore;


        foreach (Button button in buttons)
        {
            buttonNames.Add(button.name);
        }

        GameReady();
    }

    private void GameReady()
    {
        InfoText.text = "Нажми кнопку НАЧАТЬ";

        sequence.Clear();
        timeToSee = 0.7f;

        ScoreText.text = "Счет: " + 0;
        HiScoreText.text = "Лучший Счет: " + hiScore;

        StartButton.SetActive(true);
        ReturnButton.SetActive(true);
    }


    public async void GameShowing()
    {
        ReturnButton.SetActive(false);
        InfoText.text = "Запоминай последовательность";
        sequence.Add(Random.Range(0, 4));

        if (sequence.Count == 3) timeToSee = 0.5f;
        else if (sequence.Count == 6) timeToSee = 0.4f;
        else if (sequence.Count == 9) timeToSee = 0.3f;

        foreach (int i in sequence)
        {
            await ButtonBlink(buttons[i]);
        }
        GameReading();
    }

    private void GameReading()
    {
        InfoText.text = "Теперь повтори!";
        curentIndex = 0;
        EnableButtons();
    }

    public async void OnButtonPressed(string name)
    {
        if (name == buttonNames[sequence[curentIndex]])
        {
            curentIndex++;
            if (curentIndex == sequence.Count) await GameWon();
        }
        else await GameLost();
    }

    private async Awaitable GameWon()
    {
        InfoText.text = "Отлично, продолжаем!";
        ScoreText.text = "Счет: " + curentIndex;
        DisableButtons();
        await Awaitable.WaitForSecondsAsync(2.0f);
        GameShowing();
    }

    private async Awaitable GameLost()
    {
        InfoText.text = "Неверно... Попробуй еще раз";
        DisableButtons();

        hiScore = sequence.Count - 1;
        if (hiScore > YG2.saves.simonHiScore)
            YG2.saves.str += hiScore - YG2.saves.simonHiScore;
        YG2.saves.simonHiScore = hiScore;
        HiScoreText.text = "Лучший Счет: " + hiScore;

        await Awaitable.WaitForSecondsAsync(2.0f);
        GameReady();
    }



    private void DisableButtons()
    {
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
    }

    private void EnableButtons()
    {
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    private async Awaitable ButtonBlink(Button button)
    {
        var colors = button.colors;
        colors.disabledColor = colors.pressedColor;
        button.colors = colors;
        await Awaitable.WaitForSecondsAsync(timeToSee);
        colors.disabledColor = colors.normalColor;
        button.colors = colors;
        await Awaitable.WaitForSecondsAsync(timeToSee / 2);
    }


    public void ReturnToMain()
    {
        NotBG.SetActive(false);
        SceneManager.LoadScene(0);
    }
}